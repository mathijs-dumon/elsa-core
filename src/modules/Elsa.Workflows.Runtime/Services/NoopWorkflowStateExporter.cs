using Elsa.Workflows.Core.Models;
using Elsa.Workflows.Core.State;
using Elsa.Workflows.Runtime.Contracts;

namespace Elsa.Workflows.Runtime.Services;

public class NoopWorkflowStateExporter : IWorkflowStateExporter
{
    public ValueTask ExportAsync(Workflow workflow, WorkflowState workflowState, CancellationToken cancellationToken) => ValueTask.CompletedTask;
}