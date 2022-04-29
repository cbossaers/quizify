
namespace Quizify.Persistence {
    public interface IDAL2<T> {
        void Add(T param);
        void Get(string id);
        void Eliminar(string id);
        void Existe(int id);
    }
}