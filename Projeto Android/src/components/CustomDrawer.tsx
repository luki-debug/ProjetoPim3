import { StyleSheet, View, Text, Image } from 'react-native';
import React from 'react';
import { DrawerContentComponentProps } from '@react-navigation/drawer';
import { SafeAreaView } from 'react-native-safe-area-context';

import logoImage from '../images/lumiaLogo.png';
import { TouchableOpacity } from 'react-native-gesture-handler';
import { FontAwesome5 } from '@expo/vector-icons';
import { loggedContext } from '../../App';

const CustomDrawer: React.FC<DrawerContentComponentProps> = ({
  navigation,
  state,
}) => {
  const routes = state.routeNames.filter((routeName, index) => index < 5);

  return (
    <SafeAreaView style={styles.sidemenuContainer}>
      <Image resizeMode={'contain'} source={logoImage} style={styles.image} />
      <View style={styles.routesContainer}>
        {routes.map((route, index) => {
          return (
            <TouchableOpacity
              style={styles.routeContainer}
              onPress={() => {
                navigation.navigate(route);
              }}
              key={route}
            >
              {route === 'Início' && (
                <FontAwesome5
                  name='home'
                  style={
                    index === state.index ? styles.iconSelected : styles.icon
                  }
                />
              )}
              {route === 'Consultar Saldo' && (
                <FontAwesome5
                  name='wallet'
                  style={
                    index === state.index ? styles.iconSelected : styles.icon
                  }
                />
              )}
              {route === 'Investimentos' && (
                <FontAwesome5
                  name='piggy-bank'
                  style={
                    index === state.index ? styles.iconSelected : styles.icon
                  }
                />
              )}
              {route === 'Compra de Moedas' && (
                <FontAwesome5
                  name='bitcoin'
                  style={
                    index === state.index ? styles.iconSelected : styles.icon
                  }
                />
              )}
              {route === 'Fazer transações/pagar contas' && (
                <FontAwesome5
                  name='barcode'
                  style={
                    index === state.index ? styles.iconSelected : styles.icon
                  }
                />
              )}
              <Text
                style={
                  index === state.index
                    ? styles.routeTextSelected
                    : styles.routeText
                }
              >
                {route}
              </Text>
            </TouchableOpacity>
          );
        })}
        <loggedContext.Consumer>
          {([logged, setLogged]) => (
            <TouchableOpacity
              style={styles.routeContainer}
              onPress={() => {
                setLogged({ id: 0, logged: false });
              }}
            >
              <FontAwesome5 name='door-open' style={styles.icon} />
              <Text style={styles.routeText}>Logout</Text>
            </TouchableOpacity>
          )}
        </loggedContext.Consumer>
      </View>
    </SafeAreaView>
  );
};

export default CustomDrawer;

const styles = StyleSheet.create({
  sidemenuContainer: {
    width: '100%',
    height: '100%',
    backgroundColor: '#473088',
    alignItems: 'center',
    paddingHorizontal: 16,
  },
  image: {
    width: '100%',
    height: 200,
  },

  routesContainer: {
    width: '100%',
  },

  routeContainer: {
    padding: 16,
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'flex-start',
  },
  routeText: {
    fontSize: 20,
    color: '#fff',
    marginRight: 32,
  },
  routeTextSelected: {
    fontSize: 20,
    color: '#ffa200',
    marginRight: 32,
  },
  icon: {
    fontSize: 30,
    color: '#fff',
    marginRight: 16,
  },
  iconSelected: {
    fontSize: 30,
    color: '#ffa200',
    marginRight: 16,
  },
});
