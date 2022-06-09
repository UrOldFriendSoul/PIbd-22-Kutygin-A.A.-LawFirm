using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using LawFirmContracts.BindingModels;
using LawFirmContracts.BusinessLogicsContracts;
using LawFirmBusinessLogic.BusinessLogics;
using LawFirmBusinessLogic.OfficePackage;
using LawFirmBusinessLogic.OfficePackage.Implements;
using LawFirmContracts.StoragesContracts;
using LawFirmDatabaseImplement.Implements;
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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
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
            currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDocumentStorage, DocumentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDocumentLogic, DocumentLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReportLogic, ReportLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<AbstractSaveToExcel, SaveToExcel>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<AbstractSaveToWord, SaveToWord>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<AbstractSaveToPdf, SaveToPdf>(new HierarchicalLifetimeManager());
            return currentContainer;
        }

    }
}
