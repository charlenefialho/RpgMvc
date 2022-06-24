namespace RpgMvc.Models
{
    public class UsuarioViewModel
    {
        public int id {get; set;}

        public string Username {get; set;}

        public string PasswordString {get; set;}

        public byte[] Foto {get; set;}
    }
}