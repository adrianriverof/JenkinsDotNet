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
				sh "dotnet test --configuration Release --no-build --results-directory TestResults"
			}
		}
		stage ('Restore'){
        			steps {
        				sh "dotnet restore"
        			}
        		}
		stage('Build'){
			steps {
				sh 'dotnet build --configuration Release --no-restore'
			}	
		}
	}
}