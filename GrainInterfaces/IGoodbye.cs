using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface IGoodbye:Orleans.IGrainWithStringKey
    {
        Task<string> SayGoodbye(string greeting);
    }
}