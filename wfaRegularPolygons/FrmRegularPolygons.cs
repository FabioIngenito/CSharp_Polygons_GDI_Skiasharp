using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Baseado no site: Visual C# Kicks
/// C# Programming > Drawing
/// C# Drawing Regular Polygons
/// http://www.vcskicks.com/regular-polygon.php
/// 
/// Regular Polygons
/// Drawing polygons in C# is relatively easy thanks to GDI+. As far as drawing regular polygons 
/// (polygons with edges of the same size) it gets slightly tricky because we need to calculate 
/// the polygon vertices.
/// 
/// Polígonos Regulares
/// Desenhar polígonos em C# é relativamente fácil graças ao GDI+. Quanto ao desenho de polígonos regulares 
/// (polígonos com bordas do mesmo tamanho), fica um pouco complicado, porque precisamos calcular 
/// os vértices do polígono.
/// </summary>
namespace wfaRegularPolygons
{
    public partial class FrmRegularPolygons : Form
    {
        /// <summary>
        /// CTOR - Construtor
        /// </summary>
        public FrmRegularPolygons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão GDI+
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            ClsRegularPolygonsDrawing.StValues STVal = new ClsRegularPolygonsDrawing.StValues
            {
                Sides = (int)nudSides.Value,
                Radius = (int)nudRadius.Value,
                Angle = (int)nudAngle.Value,
                Siz = picCanvas.ClientSize,
                Col = lblCor.BackColor,
                Wid = (float)nudWidth.Value
            };

            Image disposeMe = picCanvas.Image;

            picCanvas.Image = ClsRegularPolygonsDrawing.DrawRegularPolygon(STVal);

            if (disposeMe != null) disposeMe.Dispose();
        }

        /// <summary>
        /// Botão Skiasharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSkia_Click(object sender, EventArgs e)
        {
            ClsRegularPolygonsSkiasharp.StValues STVal = new ClsRegularPolygonsSkiasharp.StValues
            {
                Sides = (int)nudSides.Value,
                Radius = (int)nudRadius.Value,
                Angle = (int)nudAngle.Value,
                Siz = picCanvas.ClientSize,
                Col = lblCor.BackColor,
                Wid = (float)nudWidth.Value
            };

            Image disposeMe = picCanvas.Image;

            picCanvas.Image = ClsRegularPolygonsSkiasharp.DrawRegularPolygon(STVal);

            if (disposeMe != null) disposeMe.Dispose();
        }

        /// <summary>
        /// Essa label define a cor do polígono.
        /// 
        /// Usado como exemplo:
        /// C# -  Exibindo e usando as cores disponíveis
        /// http://www.macoratti.net/16/07/c_cordisp1.htm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblCor_Click(object sender, EventArgs e)
        {
            ColorDialog minhasCores = new ColorDialog
            {
                // Permite ao usuário selecionar uma cor customizada
                AllowFullOpen = true,
                // Não permite o usuário obter ajuda 
                ShowHelp = false,
                // Define a cor inicial selecionada para a cor atual
                Color = lblCor.ForeColor
            };

            // Atualiza a cor no Label
            if (minhasCores.ShowDialog() == DialogResult.OK) lblCor.BackColor = minhasCores.Color;
        }
    }

    //Final Notes
    //Few things to note.First of all, the function returns Point objects, depending on how accurate you need the polygon-drawing to be you could use PointF instead. Both DegreesToXY and DrawPolygon already support PointF.
    //For the math, the angles are all in degrees and go counter clockwise starting with zero at the right-most midpoint of the circle.
    //Finally below is a sample C# program that wraps a nice user interface so you can view the regular polygon drawing code in action.

    //Notas Finais
    //Algumas coisas a notar.Em primeiro lugar, a função retorna objetos Point, dependendo de quão preciso você precisa que o desenho do polígono seja usado.Ambos DegreesToXY e DrawPolygon já suportam PointF.
    //Para a matemática, os ângulos são todos em graus e vão no sentido anti-horário, começando com zero no ponto médio mais à direita do círculo.
    //Finalmente, abaixo está um exemplo de programa C# que envolve uma interface de usuário agradável para que você possa visualizar o código de desenho de polígono regular em ação
}
