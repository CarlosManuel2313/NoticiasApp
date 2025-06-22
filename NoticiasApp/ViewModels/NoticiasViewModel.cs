using System.Collections.ObjectModel;
using NoticiasApp.Models;

namespace NoticiasApp.ViewModels;


    public class NoticiasViewModel
    {
        public ObservableCollection<Noticia> TodasNoticias { get; set; }
        public ObservableCollection<Noticia> UltimasNoticias { get; set; }
        public ObservableCollection<Noticia> NoticiasFavoritas { get; set; }

        public NoticiasViewModel()
        {
            TodasNoticias = new ObservableCollection<Noticia>
        {
            new Noticia { Titulo = "NASA lanza misión Artemis I para volver a la Luna", Contenido = "La NASA lanzó exitosamente la misión Artemis I, un vuelo no tripulado que probará el nuevo cohete SLS y la nave Orion para futuras misiones tripuladas a la Luna." },
            new Noticia { Titulo = "Cumbre del clima COP27 busca acuerdos para limitar el calentamiento global", Contenido = "Líderes mundiales se reúnen en Egipto para negociar medidas urgentes que reduzcan las emisiones de gases de efecto invernadero y protejan a los países más vulnerables.\r\n\r\n" },
            new Noticia { Titulo = "Avances en inteligencia artificial transforman la medicina personalizada", Contenido = "Nuevas tecnologías de IA permiten diagnósticos más precisos y tratamientos adaptados a la genética de cada paciente, mejorando la eficacia y reduciendo efectos secundarios." },
            new Noticia { Titulo = "Economía global enfrenta desafíos por inflación y conflictos internacionales", Contenido = "Expertos alertan que la inflación persistente y las tensiones geopolíticas podrían desacelerar el crecimiento económico mundial durante el próximo año." },
            new Noticia { Titulo = "Descubren una nueva especie de dinosaurio en Argentina", Contenido = "Paleontólogos argentinos identificaron fósiles de una especie de dinosaurio herbívoro gigante que vivió hace 90 millones de años, aportando información sobre la diversidad prehistórica." }
        };

            UltimasNoticias = new ObservableCollection<Noticia>(TodasNoticias.Take(2)); // Simula noticias recientes
            NoticiasFavoritas = new ObservableCollection<Noticia>();
        }

        public void AgregarAFavoritas(Noticia noticia)
        {
            if (!NoticiasFavoritas.Contains(noticia))
            {
                noticia.EsFavorita = true;
                NoticiasFavoritas.Add(noticia);
            }
        }

    }
