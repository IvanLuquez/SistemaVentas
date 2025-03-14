﻿using System.Globalization;

namespace LayerEntity.Inventory
{
    public class Product
    {
        public int idProduct { get; set; }
        public string nameProduct { get; set; }
        public int minAmount { get; set; }
        public string descriptionProduct { get; set; }
        public DateTime dateCreate { get; set; }
        public DateTime dateUpdate { get; set; }
        public string code { get; set; }
        public string unidadMedida { get; set; }
        public double precioCompra {  get; set; }
        public int amount { get; set; }
        public double weight {  get; set; }
        public int idCategoria { get; set; }
        public int idSupplier { get; set; }
        public List<ListPrice> listaPrecios { get; set; }
    }
}
