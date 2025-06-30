namespace EspacioTareas {
    public class Tarea {

        public Tarea(int Id, string Desc, int Durac)
        {
            this.TareaID = Id;
            this.Descripcion = Desc;
            this.Duracion = Durac;
        }
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }

    }

    

    
}