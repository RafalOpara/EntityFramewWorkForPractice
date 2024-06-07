namespace WebApp.Database.Repositories
{
    public interface ISettingsRepository
    {
        List<Setting> GetAll();
        void UpdateSetting(Setting setting);
        void SaveChanges();

         Setting GetSettingByName(string name);

        void DoSomething();
    }
}