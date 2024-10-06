namespace SistemaMonitoreoCarga.Models{
    public class StarshipModel{
        public int CargaPaylload { get; set; }
        public int CargaPropellant { get; set; }
        public int CargaLifeSupport { get; set; }
        public string EstadoEstabilidad { get; set; }
        public string MensajeAlerta { get; set; }

        public void CalcularDistribucionCarga(){
            int cargaTotal = CargaPaylload + CargaPropellant + CargaLifeSupport;
            int limiteOrbital = 100; // limite para la orbita baja terrestre

            if (cargaTotal > limiteOrbital){
                EstadoEstabilidad = "Sobrecargado";
                MensajeAlerta = "¡Alerta! La carga total excede el límite orbital. Redistribuya la carga.";
            }
            else if (CargaPropellant < (cargaTotal * 0.7)){ // Propelente minimo un 70%?{
                EstadoEstabilidad = "Propelente Insuficiente";
                MensajeAlerta = "Niveles de propelente bajos. Aumente la carga de propelente para el viaje.";
            }

            else if (cargaTotal == 0){
                EstadoEstabilidad = "Carga total nula";
                MensajeAlerta = "La carga total es nula. No se puede distribuir ninguna carga.";
            }
            else{
                EstadoEstabilidad = "Óptimo";
                MensajeAlerta = "La distribución de carga es óptima para el lanzamiento.";
            }
        }
    }
}