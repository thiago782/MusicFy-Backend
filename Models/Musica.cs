using System;

namespace MusicFy_Backend.Models
{



    public class Musica
    {

        //Construtor
        public Musica() => CriadoEm = DateTime.Now;

        // atributos ou propriedades

        public int Id { get; set; }
        public string nome { get; set; }
        public string estilo { get; set;}
        public string cantor { get; set; }

        public DateTime CriadoEm { get; set; }


        public override string ToString() =>
        $"Nome: {nome} | Cantor: {cantor} | Inserido em: {CriadoEm}";

    }
}