using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Database;
using WebApp.Database.Repositories;
namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WebAppDbContext _context;
        private readonly ISettingsRepository _SettingsRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SettingMapper _SettingMapper;

        public WeatherForecastController(WebAppDbContext context,
            UserManager<ApplicationUser> userManager,
            ISettingsRepository settingsRepository,
            SettingMapper settingMapper)
            
        
        // SignInManager<ApplicationUser>)signInManager)
        {
            _context = context;
            _userManager = userManager;
            _SettingsRepository = settingsRepository;
            _SettingMapper = settingMapper;

           // var user = userManager.FindByNameAsync("login").Result;   /// komentarz to metoda aby ewentualnie wyszukac uzytkownika po loginie jaki poda i mozna porownac haslo

           // signInManager.SignInAsync(user, false, "haslo123");

        }


        /*
         [HttpGet]
         public async Task<IActionResult> Index()
         {
             var user = new ApplicationUser
             {
                 FirstName = "Rafal",
                 LastName = "Opara",
                 UserName = "Opararafal"
             };

             var result =  _userManager.CreateAsync(user, "haslo123").Result;
             if (result.Succeeded)
             {
                 return Ok(); // Zwróæ kod 200 OK, jeœli dodawanie zakoñczy³o siê sukcesem
             }
             else
             {
                 return StatusCode(500); // Zwróæ kod 500 Internal Server Error w przypadku b³êdu
             }
         }
        */  // przykladowe logowanie
        /*
        [HttpGet]
        public IActionResult Index()
        {

            _SettingsRepository.UpdateSetting(new Setting
            {
                Name = "BackgroundColor",
                Value = "Pink"
            });

            var databaseSetting = _SettingsRepository.GetAll();

            return Ok(databaseSetting);


          
        }
        */
        [HttpGet]
        public IActionResult Index()
        {

            var databaseSettings = _SettingsRepository.GetAll();

            return Ok(databaseSettings);
        }

    }
}