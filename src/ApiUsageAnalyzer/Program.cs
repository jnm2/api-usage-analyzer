using ApiUsageAnalyzer;
using ApiUsageAnalyzer.Utils;
using Spectre.Console.Cli;

using var cancellation = ConsoleUtils.HandleCtrlC(out var cancellationToken);

return await new CommandApp<CliCommand>().RunAsync(args, cancellationToken);
