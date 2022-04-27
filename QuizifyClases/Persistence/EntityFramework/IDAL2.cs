
namespace Quizify.Persistence {
    public interface IDAL2<T> {
        void Add(T param);
        void Get(int id);
        void Eliminar(int id);
        void Existe(int id);
    }
}