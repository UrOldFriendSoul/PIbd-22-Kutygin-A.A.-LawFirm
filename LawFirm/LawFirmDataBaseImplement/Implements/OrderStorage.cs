using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawFirmContracts.BindingModels;
using LawFirmContracts.StorageContracts;
using LawFirmContracts.ViewModels;
using LawFirmDatabaseImplement.Models;
using LawFirmContracts.Enums;
<<<<<<< Updated upstream
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> Stashed changes

namespace LawFirmDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new LawFirmDatabase();
<<<<<<< Updated upstream
            return context.Orders.Select(CreateModel).ToList();
=======
            return context.Orders
                .Include(rec => rec.Document)
                .ToList()
                .Select(CreateModel)
                .ToList();
>>>>>>> Stashed changes
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new LawFirmDatabase();
<<<<<<< Updated upstream
            return context.Orders.Where(rec => rec.Id.Equals(model.Id)).Select(CreateModel).ToList();
=======
            return context.Orders
                .Include(rec => rec.Document)
            .Where(rec => rec.Id.Equals(model.Id) || rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo)
            .ToList()
            .Select(CreateModel)
            .ToList();
>>>>>>> Stashed changes

        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new LawFirmDatabase();
<<<<<<< Updated upstream
            var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
=======
            var order = context.Orders
                .Include(rec => rec.Document)
            .FirstOrDefault(rec => rec.Id == model.Id);
>>>>>>> Stashed changes
            return order != null ? CreateModel(order) : null;
        }
        public void Insert(OrderBindingModel model)
        {
            using var context = new LawFirmDatabase();
<<<<<<< Updated upstream
            context.Orders.Add(CreateModel(model, new Order()));
            context.SaveChanges();
=======
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
>>>>>>> Stashed changes
        }
        public void Update(OrderBindingModel model)
        {
            using var context = new LawFirmDatabase();
<<<<<<< Updated upstream
            var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
=======
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
>>>>>>> Stashed changes
        }
        public void Delete(OrderBindingModel model)
        {
            using var context = new LawFirmDatabase();
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Order CreateModel(OrderBindingModel model, Order order)
        {
            order.DocumentId = model.DocumentId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private static OrderViewModel CreateModel(Order order)
        {
            using var context = new LawFirmDatabase();
            return new OrderViewModel
            {
                Id = order.Id,
                DocumentId = order.DocumentId,
<<<<<<< Updated upstream
                DocumentName = context.Documents.FirstOrDefault(documentName => documentName.Id == order.DocumentId)?.DocumentName,
=======
                DocumentName = order.Document.DocumentName,
>>>>>>> Stashed changes
                Count = order.Count,
                Sum = order.Sum,
                Status = Enum.GetName(typeof(OrderStatus), order.Status),
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
