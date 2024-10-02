using FlowNET.Core;
using FlowNET.Core.Builder;
using FlowNET.Core.Processors;
using FlowNET.Core.Sources;
using FlowNET.Core.Triggers;

Console.WriteLine("Welcome to FlowNET!");

var pipeline = new PipelineBuilder()
    .AddTrigger(new OnceTrigger())
    .AddSource(new ExampleSource())
    .AddProcessor(new ExampleProcessor())
    .AddSink(new ExampleSink())
    .Build();

pipeline.Start();
Console.ReadLine();