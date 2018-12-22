using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ControlObjetorPerdidos.Topicos;
using ControlObjetorPerdidos.Topicos.DataBase;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Inicializo el contexto para tener acceso a la base de datos
        private DataBaseModel db = new DataBaseModel();

        [TestMethod]
        public void CrearCategoria()
        {
            //Seccion de "Arrange" o arreglo de escenario
            int vCountAntes = db.TCategoria.Count();
            TCategoria vTCat = new TCategoria()
            {
                Nombre = "Zapatos",
                Descripcion = "Zapatos que se hayan dejado en el salon de clases"
            };
            
            //Ejecucion de la prueba
            ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController vCatCont = new ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController();
            vCatCont.Create(vTCat);
            int vCountDespues = db.TCategoria.Count();

            //Verificacion del resultado obtenido
            Assert.IsTrue(vCountDespues > vCountAntes, "No se agrego la categoria");
        }

        [TestMethod]
        public void EditarCategoria()
        {
            //Seccion de "Arrange" o arreglo de escenario
            TCategoria vCat = db.TCategoria.First();
            string vNombre01 = vCat.Nombre;
            string vDescripcion01 = vCat.Descripcion;
            string vNombre02;
            string vDescripcion02; ;

            vCat.Nombre = "Ropa";
            vCat.Descripcion = "Ropa que se ha dejado en el salon de clases";
            
            //Ejecucion de la prueba
            ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController vCatController = new ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController();
            vCatController.Edit(vCat);

            //Habia un error que dice que habia dos instancias de una misma categoria, la solucion propuesta era hacer instancias desde diferentes contextos. Inicializacion del segundo contexto
            db.Dispose();
            DataBaseModel db02 = new DataBaseModel();
            TCategoria vCat02 = db02.TCategoria.First();

            vNombre02 = vCat02.Nombre;
            vDescripcion02 = vCat02.Descripcion;

            //Verificacion del resultado obtenido
            Assert.AreEqual(vNombre01, vNombre02, "No se agrego la categoria");
            Assert.AreEqual(vDescripcion01, vDescripcion02, "No se agrego la categoria");
        }

        [TestMethod]
        public void EliminarCategoria()
        {
            //Seccion de "Arrange" o arreglo de escenario
            int vCountAntes = db.TCategoria.Count();
            TCategoria vTCat = db.TCategoria.OrderByDescending(vId => vId.IdCategoria).First();     

            //Ejecucion de la prueba
            ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController vCatCont = new ControlObjetorPerdidos.Topicos.Controllers.TCategoriasController();
            vCatCont.DeleteConfirmed(vTCat.IdCategoria);
            int vCountDespues = db.TCategoria.Count();

            //Verificacion del resultado obtenido
            Assert.IsTrue(vCountDespues < vCountAntes, "No se agrego la categoria");
        }
    }
}
