using System;
using System.Collections.Generic;
using System.IO;
using SkiaSharp;
using System.Drawing;

namespace wfaRegularPolygons
{
    public class ClsRegularPolygonsSkiasharp
    {
        /// <summary>
        /// Struct that contains all the Values needed to draw.
        /// Struct que contém todos os Valores necessários para desenhar.
        /// </summary>
        public struct StValues
        {
            //Lados
            public int Sides;
            //Radianos
            public int Radius;
            //Ângulo de Começo
            public int Angle;
            //Tamanho do Canvas
            public Size Siz;
            //Cor
            public Color Col;
            //Tamanho
            public float Wid;
        }

        /// <summary>
        /// Draw a regular polygon using Skiasharp.
        /// Desenha um polígono regular usando Skiasharp.
        /// </summary>
        /// <param name="StV">Struct que contém todos os Valores necessários</param>
        /// <returns>Retorna um BITMAP</returns>
        public static Bitmap DrawRegularPolygon(StValues StV)
        {
            Bitmap polygon;
            SKPoint center = new SKPoint(StV.Siz.Width / 2, StV.Siz.Height / 2);

            //Get the location for each vertex of the polygon
            SKPoint[] verticies = CalculateVertices(StV.Sides, StV.Radius, StV.Angle, center);

            SKImageInfo imageInfo = new SKImageInfo(StV.Siz.Width, StV.Siz.Height);

            SKColor SKBackColor = new SKColor();
            SKColor.TryParse(ColorToHex(StV.Col), out SKBackColor);

            using (SKSurface surface = SKSurface.Create(imageInfo))
            {
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(SKColors.Transparent);

                // Draw any kind of Shape
                SKPaint strokePaint = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    Color = SKBackColor,
                    StrokeWidth = StV.Wid,
                    IsAntialias = true,
                };

                // Create the path
                SKPath path = new SKPath();

                // Define the drawing path points
                path.MoveTo(verticies[0].X, verticies[0].Y);

                for (int i = 1; i < verticies.Length; i++)
                {
                    path.LineTo(verticies[i].X, verticies[i].Y);
                }

                path.Close();

                canvas.DrawPath(path, strokePaint);

                using (SKImage image = surface.Snapshot())
                using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
                using (MemoryStream mStream = new MemoryStream(data.ToArray()))
                {
                    polygon = new Bitmap(mStream, false);
                }
            }

            return polygon;
        }

        /// <summary>
        /// Math
        /// The math for a regular polygon is not too difficult.Since the each of the sides are the same 
        /// length, this means the angle from the center of the polygon to each vertex in an edge 
        /// is the same for every edge.
        /// Thus we can calculate the interior angle of each edge by diving the total number of degrees 
        /// in a circle (360) by the number of sides.So for our example above, a pentagon
        /// (5-sided polygon) would have interior angles of 360/5 = 72 degrees.
        /// How do we calculate the vertices from the interior angle? Easy, we just need our degree to 
        /// coordinate code snippet.The function takes in as arguments: an origin(the center of the polygon), 
        /// a radius, and a degree.The function simply uses trigonometry to figure out how long the hypotenuse 
        /// of a right triangle would be starting at the origin at the given angle.You can look at the code 
        /// in the link above or in the sample project at the bottom of the page.
        /// It is now super easy to calculate the vertices of the polygon. With a simple loop, we can use the 
        /// degree to coordinate function at each angle interval. The code ends up looking like this:
        /// 
        /// Matemática
        /// A matemática para um polígono regular não é muito difícil.Como cada um dos lados tem o mesmo 
        /// comprimento, isso significa que o ângulo do centro do polígono para cada vértice em uma aresta 
        /// é o mesmo para todas as arestas.
        /// Assim, podemos calcular o ângulo interior de cada aresta mergulhando o número total de graus 
        /// em um círculo (360) pelo número de lados.Assim, para o nosso exemplo acima, um pentágono 
        /// (polígono de 5 lados) teria ângulos internos de 360/5 = 72 graus.
        /// Como calculamos os vértices do ângulo interior? Fácil, só precisamos do nosso grau para 
        /// coordenar o trecho de código.A função aceita como argumentos: uma origem (o centro do polígono), 
        /// um raio e um grau.A função simplesmente usa trigonometria para descobrir quanto tempo a hipotenusa 
        /// de um triângulo retângulo estaria começando na origem no ângulo dado.Você pode olhar o código 
        /// no link acima ou no projeto de amostra na parte inferior da página.
        /// Agora é super fácil calcular os vértices do polígono. Com um loop simples, podemos usar o 
        /// grau para coordenar a função em cada intervalo de ângulo.O código acaba ficando assim:
        /// </summary>
        /// <param name="sides">Lados</param>
        /// <param name="radius">Radianos</param>
        /// <param name="startingAngle">Ângulo de começo</param>
        /// <param name="center">Centro</param>
        /// <returns>Retorna uma matriz de POINTS</returns>
        private static SKPoint[] CalculateVertices(int sides, int radius, int startingAngle, SKPoint center)
        {
            if (sides < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<SKPoint> points = new List<SKPoint>();
            float step = 360.0f / sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a full circle
            {
                points.Add(DegreesToXY(angle, radius, center)); //code snippet from above
                angle += step;
            }

            return points.ToArray();
        }

        /// <summary>
        /// DegreesToXY - Graus para X e Y
        /// The .NET Framework will take care of the actual drawing logic
        /// O .NET Framework cuidará da lógica real do desenho
        /// </summary>
        /// <param name="degrees">Graus</param>
        /// <param name="radius">Radianos</param>
        /// <param name="origin">Origem</param>
        /// <returns>Retorna um "POINT"</returns>
        private static SKPoint DegreesToXY(float degrees, float radius, SKPoint origin)
        {
            SKPoint xy = new SKPoint();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }

        /// <summary>
        /// Converting System.Drawing.Color to hex
        /// https://gunnarpeipman.com/net/color-to-hex/
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>Hexadecimal</returns>
        private static string ColorToHex(Color color)
        {
            return ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb()));
        }
    }
}
