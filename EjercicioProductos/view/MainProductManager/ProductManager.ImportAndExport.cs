using EjercicioProductos.model;

namespace EjercicioProductos.view
{
    partial class ProductManager
    {
        //Dialogo de Importar CSV
        private void OpenImportDialog(object sender, EventArgs e)
        {
            if (dImport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Product> importingProducts = controller.ImportCsv(dImport.OpenFile());
                    int repeticiones = controller.CountAlreadyPresentProducts(importingProducts);
                    if (repeticiones > 0)
                    {
                        var response = MessageBox.Show("Hay " + repeticiones + " productos coincidentes. ¿Desea sobreescribir los productos actuales?",
                                "Productos ya existentes",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning);
                        if (response == DialogResult.Yes)
                        {
                            controller.InsertProducts(importingProducts);
                        }
                        else if (response == DialogResult.No)
                        {
                            controller.InsertProducts(importingProducts, false); //el método de insertar productos acepta un parámetro bool para indicar si se deben de sobreescribir las coincidencias
                        }
                    }
                    else controller.InsertProducts(importingProducts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error al importar el fichero",
                                "Error durante la importación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }

        private void OpenExportDialog(object sender, EventArgs e)
        {
            if (controller.ProductList.Count > 0)
            {
                if (dExport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        controller.ExportToCsv(dExport.OpenFile());
                        MessageBox.Show("Se ha exportado correctamente.",
                                        "Exportación correcta",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido un error durante la exportación",
                                    "Error durante la exportación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }

            }
            else MessageBox.Show("No hay productos para exportar.",
                                "Lista de productos vacía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}