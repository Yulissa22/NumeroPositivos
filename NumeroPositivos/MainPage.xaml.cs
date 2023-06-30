namespace NumeroPositivos;

///<Summary>
///<Createddate>23/06/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>23/06/2023</lastmodificationdate>
///<lastmodificationdescription>
///Al dar clic en el boton calculara el cuadrado y el cubo
///de un numero.
///</lastmodificationdescription>
///<lastmodifierautor>Erika chávez</lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
    /// <summary>
    /// constructor de la clase
    /// </summary>
    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// en el evento del boton se calculara el cuadrado y el 
	/// cubo de un numero y el resultado se mostrara en un entry.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Numero.Text))
		{
			int num, cuad, cub;
			
			num = Convert.ToInt32(Numero.Text);
			cuad = (num * 2);
			cub = (num * num * num);

			Cuadrado.Text = cuad.ToString();
			Cubo.Text = cub.ToString();
		}
		else
		{
			DisplayAlert("Error", "Asegurate de digitar un numero entero", "Gracias!");
		}
    }
}

