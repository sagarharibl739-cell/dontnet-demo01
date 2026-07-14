using Xunit;
using dotnet_demo   ; 

public class TaskManagerTests
{
    [Fact]
    public void GetPendingTaskCount_ShouldReturnCorrectCount()
    {
        var manager = new TaskManager();
        Assert.Equal(2, manager.GetPendingTaskCount());
    }

    [Fact]
    public void GetCompletedTaskCount_ShouldReturnCorrectCount()
    {
        var manager = new TaskManager();
        Assert.Equal(1, manager.GetCompletedTaskCount());
    }

    [Fact]
    public void GetNextTask_ShouldReturnFirstPending()
    {
        var manager = new TaskManager();
        Assert.Equal("Review pull request", manager.GetNextTask());
    }
}