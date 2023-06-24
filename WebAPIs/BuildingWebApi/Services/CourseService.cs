using Azure.Storage.Blobs;
using BuildingWebApi.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace BuildingWebApi.Services
{
    public class CourseService
    {
        public IWebHostEnvironment _env;
        private string storage_account_connection_string = "DefaultEndpointsProtocol=https;AccountName=alexeiappstore;AccountKey=ZD/1Fbx1Ef5UCp7nlX/0RITsS82/ymx9n/8v48Q9YoQmk16fAoxcdOBQCOnl+qiZBvswOEp57FbH+AStGvmjpg==;EndpointSuffix=core.windows.net";

        public IEnumerable<Course> GetCourses()
        {
            BlobServiceClient _blobServiceClient = new BlobServiceClient(storage_account_connection_string);
            BlobContainerClient _containerClient = _blobServiceClient.GetBlobContainerClient("data");
            BlobClient _blobClient = _containerClient.GetBlobClient("courses.json");

            var response = _blobClient.Download();
            var l_reader = new StreamReader(response.Value.Content);
            var data =  JsonSerializer.Deserialize<Course[]>(l_reader.ReadToEnd());
            return data;
        }

        public Course GetCourse(string courseId)
        {
            IEnumerable<Course> courses = this.GetCourses();
            Course course = courses.FirstOrDefault(m => m.CourseID == courseId);
            return course;
        }

        public void AddCourse(Course course)
        {
            Course[] courses;
            BlobServiceClient _blobServiceClient = new BlobServiceClient(storage_account_connection_string);
            BlobContainerClient _containerClient = _blobServiceClient.GetBlobContainerClient("data");
            BlobClient _blobClient = _containerClient.GetBlobClient("courses.json");

            var response = _blobClient.Download();
            var l_reader = new StreamReader(response.Value.Content);

            courses = JsonSerializer.Deserialize<Course[]>(l_reader.ReadToEnd());

            List<Course> courselist = courses.ToList<Course>();

            courselist.Add(course);

            var output = JsonSerializer.Serialize(courselist, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            var content = Encoding.UTF8.GetBytes(output);
            using (var ms = new MemoryStream(content))
            {
                _blobClient.Upload(ms, overwrite: true);
            }
        }
    }
}
