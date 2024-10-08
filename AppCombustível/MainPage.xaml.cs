namespace AppCombustível
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol);
                double gasolina = Convert.ToDouble(txt_gasolina);
                string msg = "";

                if (etanol <= gasolina * 0.7)
                {
                    msg = "O etanol está compensando!";
                }
                else
                {
                    msg = "A gasolina está compensando!";
                }

                DisplayAlert("Calculado", msg, "OK");

            }catch(Exception ex) 
            {
                DisplayAlert("Oops", ex.Message, "Fechar");
            }


        } //fecha método
    } //fecha class
} //fecha namespace
