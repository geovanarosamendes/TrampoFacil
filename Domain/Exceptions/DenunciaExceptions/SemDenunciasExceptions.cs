using System.Net;
using TrampoFacil.Exceptions;

namespace TrampoFacil.Exeptions
{
    public class SemDenuncias : AppExceptions
    {
        public SemDenuncias() 
                :base("Você não tem denuncias, ainda.", (int)HttpStatusCode.NotFound)
        {
        }
    }
}