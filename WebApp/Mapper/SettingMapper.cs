using AutoMapper;

namespace WebApp.Database
{
    public class SettingMapper    ///////mapper z nugetpackage - sluzy do zmapowania entity na zwykly obiekt
                                  ///////i odwrotnie dzieki czemu zapisywanie do bazy nie obejmie normalnego obiektu
    {

        private IMapper _Mapper;

        public SettingMapper()
        {
            _Mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Setting, SettingsDataModel>();  ///dostepna opcje .ReverseMap();
            }).CreateMapper();
        }

        public SettingsDataModel Map(Setting setting)
        {
            return _Mapper.Map<SettingsDataModel>(setting);
        }
    }
}
