using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CinemaServer.Models;
using System.Web.Http.Results;

namespace CinemaServer.Controllers
{
    [RoutePrefix("api/creates")]
    public class CreatesController : ApiController
    {
        private NQL_CINEMAEntities db = new NQL_CINEMAEntities();
        //ADD Movie Genre
        [HttpPost]
        [Route("moviegenre")]
        public HttpResponseMessage createGenre(MovieGenre movieGenre)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.MovieGenres.Where(i => i.Name.Equals(movieGenre.Name)).Count();
                if (validsItem != 1)
                {
                    db.MovieGenres.Add(movieGenre);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);



                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD FilmStudio
        [HttpPost]
        [Route("filmstudio")]
        public HttpResponseMessage createFilmStudio(FilmStudio filmStudio)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.FilmStudios.Where(i => i.Name.Equals(filmStudio.Name)).Count();
                if (validsItem != 1)
                {
                    db.FilmStudios.Add(filmStudio);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD Film
        [HttpPost]
        [Route("film")]
        public HttpResponseMessage createFilm(Film film)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Films.Where(i => i.Name.Equals(film.Name)).Count();
                if (validsItem != 1)
                {
                    db.Films.Add(film);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD District
        [HttpPost]
        [Route("district")]
        public HttpResponseMessage createDistrict(District district)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Districts.Where(i => i.Name.Equals(district.Name)).Count();
                if (validsItem != 1)
                {
                    db.Districts.Add(district);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD Cinema
        [HttpPost]
        [Route("cinema")]
        public HttpResponseMessage createCinema(Cinema cinema)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Cinemas.Where(i => i.Name.Equals(cinema.Name)).Count();
                if (validsItem != 1)
                {
                    db.Cinemas.Add(cinema);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD ROOM
        [HttpPost]
        [Route("room")]
        public HttpResponseMessage createRoom(Room room)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Rooms.Where(i => i.Name.Equals(room.Name)).Count();
                if (validsItem != 1)
                {
                    db.Rooms.Add(room);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD Chair
        [HttpPost]
        [Route("chair")]
        public HttpResponseMessage createChair(Chair chair)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Chairs.Where(i => i.Name.Equals(chair.Name)).Count();
                if (validsItem != 1)
                {
                    db.Chairs.Add(chair);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD COMBO
        [HttpPost]
        [Route("combo")]
        public HttpResponseMessage createCombo(Combo combo)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Comboes.Where(i => i.Name.Equals(combo.Name)).Count();
                if (validsItem != 1)
                {
                    db.Comboes.Add(combo);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD UserAccount
        [HttpPost]
        [Route("useraccount")]
        public HttpResponseMessage createUser(UserAccount userAccount)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.UserAccounts.Where(i => i.UserName.Equals(userAccount.UserName)).Count();
                if (validsItem != 1)
                {
                    db.UserAccounts.Add(userAccount);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        //ADD Employee
        [HttpPost]
        [Route("employee")]
        public HttpResponseMessage createEmployee(Employee employee)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var validsItem = db.Employees.Where(i => i.Username.Equals(employee)).Count();
                if (validsItem != 1)
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        public void convertMinsToHrsMins(decimal mins)
        {
            decimal t = Math.Floor(mins / 60);
            int h = (int)t;
            decimal t2 = mins % 60;
            int m = (int)t2;
            h = h < 10 ? '0' + h : h;
            m = m < 10 ? '0' + m : m;

        }

        //ADD MovieSchedule
        [HttpPost]
        [Route("movieschedule")]
        public HttpResponseMessage createMovieSchedule(MovieSchedule movieSchedule)
        {
            try
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var times = db.Films.Find(movieSchedule.ID_Film).Timer + 20;

                //var validsItem = db.MovieSchedules.Where
                //    (
                //    i => (i.ID_Film == movieSchedule.ID_Film)
                //    && i.TimeStart.Hours == movieSchedule.TimeStart.Hours
                //    && i.TimeStart.Minutes == movieSchedule.TimeStart.Minutes
                //    && i.Date.Month == movieSchedule.Date.Month
                //    && i.Date.Day == movieSchedule.Date.Day
                //    ).Count();

                //if (validsItem != 1)
                //{
                //    db.MovieSchedules.Add(movieSchedule);
                //    db.SaveChanges();
                //}
                //else
                //    return new HttpResponseMessage(HttpStatusCode.BadRequest);

                if (movieSchedule.TimeStart.Hours >= 8 && movieSchedule.TimeStart.Hours <= 23)
                {
                    var schedules = db.MovieSchedules.Where(o => o.ID_Film == movieSchedule.ID_Film).ToList();
                    foreach (var schedule in schedules)
                    {
                        if (schedule.Date.Equals(movieSchedule.Date))
                        {
                            //
                            return new HttpResponseMessage(HttpStatusCode.OK);
                        }
                    }
                }
                else
                    return Request.CreateResponse((HttpStatusCode)400, "TimeStart Film Requirement from 8:00-23:00");
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
