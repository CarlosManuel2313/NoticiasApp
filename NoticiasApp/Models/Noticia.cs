namespace NoticiasApp.Models;

public class Noticia
{
    public string Titulo { get; set; } = string.Empty;
    public string Contenido { get; set; } = string.Empty;
    public bool EsFavorita { get; set; }
}
