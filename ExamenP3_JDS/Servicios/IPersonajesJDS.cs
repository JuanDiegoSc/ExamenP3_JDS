using ExamenP3_JDS.Models;

namespace ExamenP3_JDS.Servicios
{
    public interface IPersonajesJDS
    {
        public Task<List<PersonajesJDS>> ObtenerPersonaje();
    }

}
