namespace CognitiveTask.App_Start
{
    public interface IServiceCollection
    {
        void AddMvc();
        void AddSingleton<T1, T2>();
    }
}