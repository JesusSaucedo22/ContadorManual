namespace ContadorManual
{
    public partial class MainPage : ContentPage
    {

        private int _conteo;

        public MainPage()
        {
            InitializeComponent();
            _conteo = 0;
            ConteoLabel.Text = _conteo.ToString();
        }


        private void Button_Clicke(Object sender, EventArgs e)
        {
            _conteo++;
            ConteoLabel.Text = _conteo.ToString();
        }

        private void Button_Clicke_1(Object sender, EventArgs e)
        {
            _conteo = 0;
            ConteoLabel.Text = _conteo.ToString();

        }
        //Cambiamos la parte grafica agregandole un Grid....


    }
}