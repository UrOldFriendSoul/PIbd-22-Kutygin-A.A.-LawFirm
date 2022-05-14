using LawFirmBusinessLogic.BusinessLogics;
using LawFirmContracts.BusinessLogicContracts;
using LawFirmContracts.StorageContracts;
using LawFirmFileImplement.Implements;
using LawFirmFileImplement;
using LawFirmContracts.Enums;
using LawFirmListImplement.Models;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace LawFirmView
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
            FileDataListSingleton.Save();
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentStorage, ComponentStorage> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDocumentStorage, DocumentStorage> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseStorage, WarehouseStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComponentLogic, ComponentLogic> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDocumentLogic, DocumentLogic> (new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseLogic, WarehouseLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }

    }
}