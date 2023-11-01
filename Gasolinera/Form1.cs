namespace Gasolinera
{
    public partial class Form1 : Form
    {
        double contador = 0;
        int cantidadGalones = 0;
        const double precioRegular = 1.41;
        const double precioPremium = 1.90;
        const double precioSuperPremium = 3.0;
        double precioTotal = 0.0;
        string tipoCombustibleSeleccionado = "";
        public Form1()
        {
            InitializeComponent();


        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            //Total(btnRegular.Text, cantidadGalones);

            tipoCombustibleSeleccionado = btnRegular.Text;

            ActualizarGalonesPrecio();

            timer1.Enabled = true;


        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            //Total(btnPremium.Text, cantidadGalones);

            tipoCombustibleSeleccionado = btnPremium.Text;

            ActualizarGalonesPrecio();

            timer1.Enabled = true;
        }

        private void btnSuperPremium_Click(object sender, EventArgs e)
        {
            cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            //Total(btnSuperPremium.Text, cantidadGalones);

            tipoCombustibleSeleccionado = btnSuperPremium.Text;

            ActualizarGalonesPrecio();

            timer1.Enabled = true;


        }

        //public void Total(string tipoCombustible, int cantGalones)
        //{
        //    double total = 0;

        //    switch (tipoCombustible)
        //    {
        //        case "Regular":
        //            total = precioRegular * cantGalones;
        //            lblTotal.Text = String.Format("{0:C}", total);
        //            break;
        //        case "Premium":
        //            total = precioPremium * cantGalones;
        //            lblTotal.Text = String.Format("{0:C}", total);
        //            break;
        //        case "Super Premium":
        //            total = precioSuperPremium * cantGalones;
        //            lblTotal.Text = String.Format("{0:C}", total);
        //            break;
        //    }

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador + 0.25;

            if (contador <= cantidadGalones)
            {
                ActualizarGalonesPrecio();
                txtNumeroGalones.Text = contador.ToString();
            }
        }

        public void ActualizarGalonesPrecio()
        {
            if (tipoCombustibleSeleccionado != "" && contador > 0)
            {
                double precioBase = ObtenerPrecioBasePorTipo(tipoCombustibleSeleccionado);
                precioTotal = precioBase * contador;
                lblTotal.Text = string.Format("{0:C}", precioTotal);
            }
        }

        private double ObtenerPrecioBasePorTipo(string tipo)
        {
            switch (tipo)
            {
                case "Regular":
                    return precioRegular;
                case "Premium":
                    return precioPremium;
                case "Super Premium":
                    return precioSuperPremium;
                default:
                    return 0.0;
            }
        }

    }
}