﻿using LawFirmContracts.Enums;
using LawFirmFileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace LawFirmFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string ComponentFileName = "Component.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string DocumentFileName = "Document.xml";
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Document> Documents { get; set; }
        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Orders = LoadOrders();
            Documents = LoadDocuments();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveComponents();
            SaveOrders();
            SaveDocuments();
        }
        private List<Component> LoadComponents()
        {
            var list = new List<Component>();
            if (File.Exists(ComponentFileName))
            {
                var xDocument = XDocument.Load(ComponentFileName);
                var xElements = xDocument.Root.Elements("Component").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                var xDocument = XDocument.Load(OrderFileName);
                var xElements = xDocument.Root.Elements("Order").ToList();
                foreach (var elem in xElements)
                {
                    var dateImpl = elem.Element("DateImplement").Value;
                    if (dateImpl != string.Empty)
                    {
                        list.Add(new Order
                        {
                            Id = Convert.ToInt32(elem.Attribute("Id").Value),
                            DocumentId = Convert.ToInt32(elem.Element("DocumentId").Value),
                            Count = Convert.ToInt32(elem.Element("Count").Value),
                            Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                            Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
                            DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
                            DateImplement = Convert.ToDateTime(elem.Element("DateImplement").Value)
                        });
                    }
                    else
                    {
                        list.Add(new Order
                        {
                            Id = Convert.ToInt32(elem.Attribute("Id").Value),
                            DocumentId = Convert.ToInt32(elem.Element("DocumentId").Value),
                            Count = Convert.ToInt32(elem.Element("Count").Value),
                            Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                            Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
                            DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value)
                        });
                    }
                }
            }
            return list;
        }
        private List<Document> LoadDocuments()
        {
            var list = new List<Document>();
            if (File.Exists(DocumentFileName))
            {
                var xDocument = XDocument.Load(DocumentFileName);
                var xElements = xDocument.Root.Elements("Document").ToList();
                foreach (var elem in xElements)
                {
                    var docComp = new Dictionary<int, int>();
                    foreach (var component in elem.Element("DocumentComponents").Elements("DocumentComponent").ToList())
                    {
                        docComp.Add(Convert.ToInt32(component.Element("Key").Value), Convert.ToInt32(component.Element("Value").Value));
                    }
                    list.Add(new Document
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        DocumentName = elem.Element("DocumentName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value),
                        DocumentComponents = docComp
                    });
                }
            }
            return list;
        }
        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");
                foreach (var component in Components)
                {
                    xElement.Add(new XElement("Component",
                    new XAttribute("Id", component.Id),
                    new XElement("ComponentName", component.ComponentName)));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(ComponentFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");
                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                    new XAttribute("Id", order.Id),
                    new XElement("DocumentId", order.DocumentId),
                    new XElement("Count", order.Count),
                    new XElement("Sum", order.Sum),
                    new XElement("Status", order.Status),
                    new XElement("DateCreate", order.DateCreate),
                    new XElement("DateImplement", order.DateImplement)));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveDocuments()
        {
            if (Documents != null)
            {
                var xElement = new XElement("Documents");
                foreach (var document in Documents)
                {
                    var compElement = new XElement("DocumentComponents");
                    foreach (var component in document.DocumentComponents)
                    {
                        compElement.Add(new XElement("DocumentComponent",
                        new XElement("Key", component.Key),
                        new XElement("Value", component.Value)));
                    }
                    xElement.Add(new XElement("Document",
                     new XAttribute("Id", document.Id),
                     new XElement("DocumentName", document.DocumentName),
                     new XElement("Price", document.Price), compElement));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(DocumentFileName);
            }
        }
        public static void Save() 
        {
            instance.SaveOrders();
            instance.SaveDocuments();
            instance.SaveComponents();
        }
    }
}
