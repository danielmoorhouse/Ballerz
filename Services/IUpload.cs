 using Microsoft.WindowsAzure.Storage.Blob;

 namespace Ballerz.Services
 {
     public interface IUpload
     {
          CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer2(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer3(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer4(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer5(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer6(string connectionString, string containerName);
          CloudBlobContainer GetBlobContainer7(string connectionString, string containerName);
     }
 }