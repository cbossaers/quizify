namespace Quizify.Persistence {
    public interface IDAL2<T> {
        void Add(T param);
        T Get<K>(K param);
        void Eliminar<K>(K param);
    }
}