public class MultiResponse
{
    [CosmosDBOutput(databaseName:"MulticloudResume", collectionName: "Counter",
        ConnectionStringSetting = "CosmosDbConnectionString", CreateIfNotExists = true)]
    public Counter Document { get; set; }
    public HttpResponseData HttpResponse { get; set; }
}

public class Counter {
    public string id { get; set; }
    public string count { get; set; }
}
