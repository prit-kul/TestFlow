using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using TestFlow.Domain.Entities;

namespace TestFlow.Tests;

public class EmployeeApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public EmployeeApiTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetEmployees_ReturnsOk()
    {
        // Act
        var response = await _client.GetAsync("/api/employees");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    
    [Fact]
    public async Task GetEmployees_ReturnsTwoEmployees()
    {
        // Arrange: prepare the request
        var response = await _client.GetAsync("/api/employees");

        // Assert: verify the HTTP response
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        // Read the JSON response into C# objects
        var employees =
            await response.Content.ReadFromJsonAsync<List<Employee>>();

        // Assert: verify the returned data
        Assert.NotNull(employees);
        Assert.Equal(2, employees.Count);
    }

    
[Fact]
public async Task CreateEmployee_WithValidData_ReturnsCreatedEmployee()
{
    // Arrange: prepare the employee data
    var newEmployee = new
    {
        Name = "Rahul Verma",
        Email = "rahul@example.com",
        Level = 3,
        Role = 2
    };

    // Act: send a POST request with JSON data
    var response = await _client.PostAsJsonAsync(
        "/api/employees",
        newEmployee);

    // Assert: verify the HTTP status
    Assert.Equal(
        HttpStatusCode.Created,
        response.StatusCode);

    // Assert: verify the returned employee
    var createdEmployee =
        await response.Content.ReadFromJsonAsync<Employee>();

    Assert.NotNull(createdEmployee);
    Assert.Equal("Rahul Verma", createdEmployee.Name);
    Assert.Equal("rahul@example.com", createdEmployee.Email);
    Assert.NotEqual(Guid.Empty, createdEmployee.Id);
}


[Fact]
public async Task CreateEmployee_WithBlankName_ReturnsBadRequest()
{
    // Arrange: prepare invalid employee data
    var newEmployee = new
    {
        Name = "",
        Email = "rahul@example.com",
        Level = 3,
        Role = 2
    };

    // Act: send the POST request
    var response = await _client.PostAsJsonAsync(
        "/api/employees",
        newEmployee);

    // Assert: the API should reject invalid input
    Assert.Equal(
        HttpStatusCode.BadRequest,
        response.StatusCode);
}
}