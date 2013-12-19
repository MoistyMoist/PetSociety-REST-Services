using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace PetSocietyWebServices.Controllers.Utils
{
    public class UploadImageController : ApiController
    {
        [HttpPost]
        public string postTest([FromBody] string base64)
        {
            DateTime date = new DateTime();
            string fileName = date.ToString();

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.WindowsAzure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            storageAccount.CreateCloudBlobClient();
            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("petsociety");
            container.CreateIfNotExists();

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileName);

            byte[] bytes = Convert.FromBase64String(base64);

            using (var stream = new MemoryStream(bytes))
            {
                blockBlob.UploadFromStream(stream);
            }

            string url = "http://114173s.blob.core.windows.net/bartertrading/" + fileName;

           
            return url;
        }
    }
}
