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
				sh "dotnet test --configuration ${TARGET_FRAMEWORK} --no-build --results-directory TestResults"
			}
		}
		stage ('Restore'){
        			steps {
        				sh "dotnet restore"
        			}
        		}
		stage('Build'){
			steps {
				sh 'dotnet build --configuration ${TARGET_FRAMEWORK} --no-restore'
			}	
		}
		stage('Publish') {
            steps {
                sh '''
                    mkdir -p "Publish"
                    dotnet publish --configuration ${TARGET_FRAMEWORK} --no-build --output "Publish/JenkinsTest" --framework net6.0
                '''
                archiveArtifacts artifacts: 'Publish/**/*', fingerprint: true
            }
        }
	}
}