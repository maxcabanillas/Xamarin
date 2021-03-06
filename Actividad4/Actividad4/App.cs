﻿using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//Se crea un objeto etiqueta
			//Label label = new Label();

			//Se modifican sus propiedades
			//Texto
			//label.Text = "Cámbiame";
			//Color del texto
			//label.TextColor = Color.Blue;
			//Alineación vertical (YAlign). Para la alineación horizontal, usar XAlign
			//label.YAlign = TextAlignment.Center;


			//El mismo código usando inicializador de objetos
			Label label = new Label
			{
				Text = "NAVA_A_JOSE_U1_ACT4_PROG_DISP_MOVILES",
				TextColor =  Color.Green,
				YAlign = TextAlignment.Center
				};

			//Se crea una página y se le asigna como contenido la eqtiqueta que se creó
			ContentPage contentPage = new ContentPage();
			contentPage.Content = label;

			return contentPage;
		}
	}
}

