pipeline {
	agent any
	
	stages {
		stage ('Checkout'){
			steps {
				cleanWs()
				sh "git clone https://github.com/adrianriverof/JenkinsDotNet.git ."
			}
		}
		stage ('Restore'){
			steps {
				sh "dotnet restore"
			}
		}
		stage ('Test'){
			steps {
				sh "dotnet test --configuration Release --results-directory TestResults"
			}
		}
		stage('Build'){
			steps {
				sh 'dotnet build --configuration Release --no-restore'
			}	
		}
	}
}