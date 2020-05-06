using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.CourseAggregate;

namespace Infrastructure.Data
{
    public class LearnContextSeed
    {
        public static async Task SeedAsync(LearnContext learnContext,
                                            ILoggerFactory loggerFactory,
                                            int? retry = 0)
        {
            int retryForAvaliability = retry.Value;

            try
            {
                if (!learnContext.Courses.Any())
                {
                    learnContext.Courses.AddRange(
                        GetPreconfiguredCourses());

                    await learnContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                if (retryForAvaliability < 10)
                {
                    retryForAvaliability++;
                    var log = loggerFactory.CreateLogger<LearnContextSeed>();
                    log.LogError(e.Message);
                    await SeedAsync(learnContext, loggerFactory, retryForAvaliability);
                }
                throw;
            }
        }

        private static IEnumerable<Course> GetPreconfiguredCourses()
        {
            return new List<Course>()
            {
                new Course()
            };
        }
    }
}
