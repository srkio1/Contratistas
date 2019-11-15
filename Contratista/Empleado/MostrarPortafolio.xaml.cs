﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contratista.Empleado
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MostrarPortafolio : ContentPage
	{
        int IdPortafolio;
        string NombreP;
        string Imagen_1P;
        string Imagen_2P;
        string Imagen_3P;
        string Imagen_4P;
        string Imagen_5P;
        string Imagen_6P;
        string Imagen_7P;
        int IdProfesional;
        int imgPick;
        public MostrarPortafolio(int id_portafolio, string nombre, string imagen_1, string imagen_2, string imagen_3, string imagen_4, string imagen_5, string imagen_6,
                                 string imagen_7, int id_profesional)
        {
            InitializeComponent();



            List<CustomData> GetDataSource()
            {
                List<CustomData> list = new List<CustomData>();
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_1));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_2));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_3));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_4));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_5));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_6));
                list.Add(new CustomData("http://dmrbolivia.online" + imagen_7));
                return list;
            }
            rotator.ItemsSource = GetDataSource();
            TituloTxt.Text = nombre;
        }
    }
}