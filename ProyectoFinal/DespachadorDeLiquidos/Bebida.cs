using System;

namespace DespachadorDeLiquidos
{
    class Bebida
    {
        #region Atributos
        private string alcohol;
        private string refresco;
        private int cantidadAlcohol;
        private int cantidadRefresco;
        private int cantidadAgua;
        private byte hielos;
        #endregion

        #region Propiedades
        //Cada porción, es decir, cada vaso, tiene 250 ml 
        public string Alcohol { get => alcohol; set => alcohol = value; }
        public string Refresco { get => refresco; set => refresco = value; }
        public int CantidadAlcohol
        {
            get => cantidadAlcohol;
            set
            {
                if (value > 250 || value <1)
                {
                    cantidadAlcohol = 50;
                }
                else
                {
                    cantidadAlcohol = value;
                }
            }
        }
        public int CantidadRefresco
        {
            get => cantidadRefresco;
            set
            {
                if (value > 250 || value < 1)
                {
                    cantidadRefresco =150;
                }
                else
                {
                    cantidadRefresco = value;
                }
            }
        }
        public int CantidadAgua
        {
            get => cantidadAgua;
            set
            {
                if (value > 250 || value < 1)
                {
                    cantidadAgua = 50;
                }
                else
                {
                    cantidadAgua = value;
                }
            }
        }
        public byte Hielos
        {
            get => hielos;
            set
            {
                if (value > 20 || value < 1)
                {
                    hielos = 4;
                }
                else
                {
                    hielos = value;
                }
            }
        }
        #endregion
    }
}
