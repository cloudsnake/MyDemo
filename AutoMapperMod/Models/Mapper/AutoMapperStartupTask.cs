namespace AutoMapperMod.Models.Mapper
{
    ////第一步 
    ////注册映射配置
    //AutoMapperStartupTask auto = new AutoMapperStartupTask();
    //auto.Execute();


    public class AutoMapperStartupTask
    {
        public void Execute()
        {
            AutoMapperConfiguration.Init();
        }
    }
}