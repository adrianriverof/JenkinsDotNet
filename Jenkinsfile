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
		stage('Build'){
			steps {
				sh 'dotnet build --configuration Publish --no-restore'
			}	
		}
		
		stage ('Test'){
			steps {
				//sh "dotnet test --configuration Publish --no-build --results-directory TestResults"
				sh "dotnet test --configuration Release --no-build --results-directory TestResults"
	
			}
		}
		
		stage('Publish') {
            steps {
                sh '''
                    mkdir -p "Publish"
                    dotnet publish --configuration Publish --no-build --output "Publish/JenkinsTest" --framework net6.0
                '''
                archiveArtifacts artifacts: 'Publish/**/*', fingerprint: true
                
            }
        }
	}
}