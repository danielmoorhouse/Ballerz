using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ballerz.Web;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Ballerz.Data;
using Ballerz.Services;
using Ballerz.Services.Implementations;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Reflection;
using Ballerz.Data.Models;

namespace Ballerz.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //store connection string as a var
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.Stores.MaxLengthForKeys = 128)
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultUI()
           .AddDefaultTokenProviders();
           services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddScoped<ITeam, TeamService>();
            services.AddScoped<ILeague, LeagueService>();
            services.AddScoped<IUpload, UploadService>();
            services.AddScoped<ICountries, CountriesService>();
            services.AddScoped<IManager, ManagerService>();
            services.AddScoped<IStadium, StadiumService>();
            services.AddScoped<ISeason, SeasonService>();
            services.AddScoped<IClubHistory, ClubHistoryService>();
            services.AddScoped<IPlayerHistory, PlayerHistoryService>();
            services.AddScoped<IPosition, PositionService>();
            services.AddScoped<IPlayer, PlayerService>();
              services.AddScoped<IForum, ForumService>();
            services.AddScoped<IPost, PostService>();
            services.AddScoped<IUpload, UploadService>();
            services.AddScoped<IApplicationUser, ApplicationUserService>();
            services.AddScoped<IProfile, ProfileService>();
            services.AddScoped<INotification, NotificationService>();

            services.AddSingleton<IFileProvider>(
            new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            services.AddSingleton(Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                  .AddRazorPagesOptions(options =>
        {
            options.AllowAreas = true;
            options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
            options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
        });
            services.ConfigureApplicationCookie(options =>
       {
           options.LoginPath = $"/Identity/Account/Login";
           options.LogoutPath = $"/Identity/Account/Logout";
           options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
       });
            services.AddSignalR();
            //services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext context,
                        RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            var supportedCultures = new[] { new CultureInfo("en-GB") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-GB"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            DataSeeder.Initialize(context, userManager, roleManager).Wait();// seed here
        }
    }
}
