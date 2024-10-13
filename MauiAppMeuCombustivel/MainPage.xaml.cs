namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
              InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Capturando o texto dos campos de entrada
                string modelo = txt_modelo.Text;
                string marca = txt_marca.Text;

                // Convertendo os preços para double
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                // Variável para armazenar a mensagem
                string msg = "";

                // Verificando qual combustível compensa mais
                if (etanol <= (gasolina * 0.7))

                {
                    msg = $"O Etanol está compensando para o veículo {marca} {modelo}.";

                } else
                {
                    msg = $"A Gasolina está compensando para o veículo {marca} {modelo}.";
                }

                // Exibindo a mensagem
                DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)

            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }



        } //Fecha Método
    } //Fecha Class

} // Fecha namespace
