using System;
using MultiInterfaceLib;

public partial class Phone : System.Web.UI.Page
{
    IMusicPlayer music;
    ICamera camera;
    SmartPhone phone;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPhoto_Click(object sender, EventArgs e)
    {
        phone = new SmartPhone();
        camera = phone;

        lblPhoto.Text = camera.TakePhoto();
    }

    protected void btnMusic_Click(object sender, EventArgs e)
    {
        phone = new SmartPhone();
        music = phone;

        lblMusic.Text = music.PlayMusic();
    }
}