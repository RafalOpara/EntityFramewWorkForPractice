using Microsoft.EntityFrameworkCore;
using WebApp.Database.Repositories.Base;

namespace WebApp.Database.Repositories
{
    public class SettingsRepository : BaseRepository<Setting>, ISettingsRepository
    {

        protected override DbSet<Setting> DbSet => _context.Settings;


        public SettingsRepository(WebAppDbContext dbContext) : base(dbContext) { }



        public void UpdateSetting(Setting setting)
        {
            var foundSetting = DbSet.Where(x => x.Name == setting.Name).FirstOrDefault();

            if (foundSetting == null)
            {
                DbSet.Add(setting);
                SaveChanges();
                return;
            }
            else
            {
                foundSetting.Name = setting.Name;
                foundSetting.Value = setting.Value;
                SaveChanges();
            }
            
            

        }

        public Setting GetSettingByName(string name)
        {
            var foundSetting = DbSet.Where(x=>x.Name==name).FirstOrDefault();

            return foundSetting;
        }


        public void DoSomething()
        {
            // var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6).Select(x => x.Value);             ///funckja dla praktyki --- select wyciaga konkretne wartosci ze ciala setting

            // var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6).OrderBy(x => x.Name); /// funckja orderBy - sortuje w tym przypadku po nazwie

            //var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6).Take(2); /// funckja Take(2) pobiera 2 pierwsze elementy jakie znajdzie where

            //var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6).Skip(2); /// funcka Skip(2) pominie 2 elementy i wezmie pozostale

            // var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6).Skip(2).Select(x=>x.Value).OrderBy(x=>x).Take(1).ToList(); ///
            // połączenie wielu funkcji moze tak wygladac - ponizej czytelniejsza werjsa:

            var foundSetting = DbSet.Where(x => x.Id > 3 && x.Id < 6)
                .Skip(2).
                Select(x => x.Value).
                OrderBy(x => x).Take(1).
                ToList();

            var list = foundSetting.ToList();
        }


    }


}
