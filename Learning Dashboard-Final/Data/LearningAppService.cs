using System.Net.Http.Json;

namespace Learning_Dashboard_Final.LearningApp
{
    public class LearningAppService
    {
        private readonly HttpClient http;

        public LearningAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<CurrentlyAttendingType[]?> GetCurrentlyAttending()
        {
            return await this.http.GetFromJsonAsync<CurrentlyAttendingType[]>("https://excel2json.io/api/share/411814c4-bebf-4b2c-e661-08dab79fa5b4");
        }

        public async Task<CategoriesType[]?> GetCategories()
        {
            return await this.http.GetFromJsonAsync<CategoriesType[]>("https://excel2json.io/api/share/c7c0f004-5d70-41db-e663-08dab79fa5b4");
        }

        public async Task<PopularLecturersType[]?> GetPopularLecturers()
        {
            return await this.http.GetFromJsonAsync<PopularLecturersType[]>("https://excel2json.io/api/share/f2c280b7-2b1b-47c5-e662-08dab79fa5b4");
        }

        public async Task<AllCoursesType[]?> GetAllCourses()
        {
            return await this.http.GetFromJsonAsync<AllCoursesType[]>("https://excel2json.io/api/share/28f292a3-d187-48c4-e660-08dab79fa5b4");
        }
    }
}