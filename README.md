# AssurityTest
API Test for assurity recruitment

Important information for using this API automation framework:

Reusable methods for calling different endpoints for rest APIs are in Helpers/RestHelper:
GetRequest(string endpoint) - for GET requests.
CreateOrUpdateRequest(string method, string endpoint, dynamic payload) - for POST, PUT and PATCH requests. This method accepts a payload of any object type.
DeleteRequest(string endpoint) - for DELETE requests.

Reusable method for deserializing responses returned by the API is in Helpers/DeserializationHelper:
Deserialize<T>(IRestResponse response) - deserializes a response of a specific type <T> contained in the IRestResponse passed in as a parameter.
  
Hooks - for all specflow hooks files.

Models - for all C# models of JSON responses or requests. Objects should be in relevant folders and common objects should be in the Common folder.

Features - Contains all feature files. Features should separated in their own folders but in this case, its only one feature.

StepDefinitions - Contains all step definitions for the features. Step definitions should be structured in the same way as the Features folder (separated into their own folders for finding things easily).

If the API has POST, PUT, etc requests that require payload creation, create a new folder Builders and add builder classes in there to create your payloads.
