using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

/// <summary>
/// Baseado no site: Visual C# Kicks
/// C# Programming > Drawing
/// C# Drawing Regular Polygons
/// http://www.vcskicks.com/regular-polygon.php
/// </summary>
namespace wfaRegularPolygons
{
    public class ClsRegularPolygonsDrawing
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
        /// Drawing
        /// Drawing the polygon on an image is as simple as using the DrawPolygon function 
        /// in the System.Drawing.Graphics class:
        /// 
        /// Desenhando
        /// Desenhar o polígono em uma imagem é tão simples quanto usar a função DrawPolygon 
        /// na classe System.Drawing.Graphics:
        /// </summary>
        /// <param name="StV">Struct que contém todos os Valores necessários</param>
        /// <returns>Retorna um BITMAP</returns>
        public static Bitmap DrawRegularPolygon(StValues StV)
        {
            Pen pCor = new Pen(StV.Col, StV.Wid);
            Point center = new Point(StV.Siz.Width / 2, StV.Siz.Height / 2);

            //Get the location for each vertex of the polygon
            Point[] verticies = CalculateVertices(StV.Sides, StV.Radius, StV.Angle, center);

            //Render the polygon
            Bitmap polygon = new Bitmap(StV.Siz.Width, StV.Siz.Height);

            using (Graphics g = Graphics.FromImage(polygon))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.DrawPolygon(pCor, verticies);
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
        private static Point[] CalculateVertices(int sides, int radius, int startingAngle, Point center)
        {
            if (sides < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<Point> points = new List<Point>();
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
        private static Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }
    }
}
