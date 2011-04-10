require 'albacore'

task :default => :unittests

msbuild :build do |msb|
  msb.solution = 'chequewriter.sln'
  msb.targets :clean, :build
  msb.properties :configuration => :debug
end

nunit :unittests => :build do |nunit|
  nunit.path = 'nunit/nunit-console.exe'
  nunit.assemblies 'src/tests/bin/release/tests.dll'
end