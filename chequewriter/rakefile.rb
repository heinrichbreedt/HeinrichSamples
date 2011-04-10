require 'albacore'

task :default => :unittests

msbuild :build do |msb|
  msb.solution = 'chequewriter.sln'
  msb.targets :clean, :build
  msb.properties :configuration => :debug
end

nunit :unittests => :build do |nunit|
  nunit.command = 'packages/NUnit.2.5.9.10348/Tools/nunit-console.exe'
  nunit.assemblies 'TestBin/chequetools.test.dll'
end