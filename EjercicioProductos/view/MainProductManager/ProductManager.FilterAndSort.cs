namespace EjercicioProductos.view
{
    partial class ProductManager
    {
        private void RemoveFilters(object sender, EventArgs e)
        {
            RemoveFilters();
        }

        //Establece el critero de ordenamiento
        private void SetOrderingRules(object sender, EventArgs e)
        {
            String field = "";
            bool direction = (tscbOrderDirection.SelectedIndex == 0);
            switch (tscbOrderField.SelectedIndex)
            {
                case 0: field = "Id"; break;
                case 1: field = "Name"; break;
                case 2: field = "Quantity"; break;
                case 3: field = "Price"; break;
                case 4: field = "Description"; break;
                case 5: field = "Type"; break;
            }

            controller.SetOrderingRules(field, direction);
        }

        //En la casilla de cantidad solo dejamos numeros
        private void tbQuantityFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        //En la de precio, numeros y comas
        private void tbPriceFIlter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as ToolStripTextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void RemoveFilters()
        {
            //Limpiamos todos los campos de filtro
            tbNameFilter.Text = tbCodeFilter.Text = tbQuantityFilter.Text = tbPriceFIlter.Text = cbTypeFilter.Text = String.Empty;
            //Limpiamos los filtros del controlador
            controller.Filter.Values.ToList().ForEach(value => value = String.Empty);
            controller.UpdateShowingProducts();
        }

        //Notifica de que el filtro ha sido modificado
        private void FilterModified(object sender, KeyEventArgs e)
        {
            ToolStripTextBox writedElement = (ToolStripTextBox)sender;

            controller.Filter[(String)writedElement.Tag] = writedElement.Text;

            controller.UpdateShowingProducts();
        }

        //Gestiona el cambio de tipo en el filtro, ya que es un combo
        private void TypeFilterModified(object sender, EventArgs e)
        {
            controller.Filter["Type"] = cbTypeFilter.Text;
            controller.UpdateShowingProducts();
        }
    }
}