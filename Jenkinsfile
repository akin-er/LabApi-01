pipeline {
    agent { label 'ec2' }

    stages {
        stage('Docker Build') {
            steps {
                echo 'Building'
                sh 'docker build --rm -t labapi-01:latest .'
            }
        }


        stage('Docker Run') {
            steps {
                echo 'Publish'
                sh 'docker run --rm -p 5000:5000 -e ASPNETCORE_URLS=http://+:5000 labapi-01'
            }
        }

    }
}
