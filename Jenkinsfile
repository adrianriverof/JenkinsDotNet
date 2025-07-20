pipeline {
	agent any
	
	stages {
		stage ('Checkout'){
			steps {
				cleanWs()
				sh "git clone https://github.com/adrianriverof/JenkinsDotNet.git ."
			}
		}
		stage ('Test'){
			steps {
				sh "dotnet test --configuration Release --results-directory TestResults"
			}
		}
	}
}