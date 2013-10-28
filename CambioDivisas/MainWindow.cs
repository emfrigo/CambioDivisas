using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private decimal tipoCambio;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}	

	protected void cambioClick (object sender, EventArgs e)
	{
		if (txtPesos.Text == "" && txtDolares.Text != "") {
			try{
				txtPesos.Text = Convert.ToString(
					decimal.Parse(txtDolares.Text) / 
					decimal.Parse(tCambio.Text)
					);
			}catch(Exception){
				new MessageDialog (
				this, 
				DialogFlags.Modal,
				MessageType.Error,
				ButtonsType.None,
				"Inbrese solo numeros",
				this.Title = "Error"
				).Show();
			}
	}

		if (txtDolares.Text == "" && txtPesos.Text != "") {
				try{
				txtDolares.Text = Convert.ToString(
					decimal.Parse(txtPesos.Text) * 
					decimal.Parse(tCambio.Text)
					);
			}catch(Exception){
				new MessageDialog (
				this, 
				DialogFlags.Modal,
				MessageType.Error,
				ButtonsType.None,
				"Ingrese solo numeros",
				this.Title = "Error"
				).Show();
			}

		}
	}


}
