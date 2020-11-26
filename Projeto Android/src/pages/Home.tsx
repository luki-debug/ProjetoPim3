import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import { StyleSheet, View, Text } from 'react-native';
import { ScrollView } from 'react-native-gesture-handler';
import Header from '../components/Header';
import { MaterialCommunityIcons } from '@expo/vector-icons';
import { PieChart } from 'react-native-svg-charts';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';
import { loggedContext } from '../../App';

const Home: React.FC<DrawerScreenProps<{}>> = ({ navigation, route }) => {
  const [user] = useContext(loggedContext);
  const [disponivel, setDisponivel] = useState(-1);
  const [retido, setRetido] = useState(-1);
  const [patrimonio, setPatrimonio] = useState(-1);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    api
      .get(`investimento/${user.id}`)
      .then((response) => {
        if (response.status === 200) {
          const {
            PatrimonioTotal,
            TotalDisponivel,
            TotalRetido,
          } = response.data;

          setDisponivel(TotalDisponivel);
          setRetido(TotalRetido);
          setPatrimonio(PatrimonioTotal);
        }

        setLoading(false);
      })
      .catch((err) => {
        console.error(err);

        setLoading(false);
      });
  }, []);

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.homeContainer}>
          {!loading && (
            <PieChart
              style={{ height: 200 }}
              outerRadius='100%'
              innerRadius='70%'
              data={[
                {
                  value: disponivel,
                  svg: {
                    fill: '#17ACE6',
                  },
                  key: `pie-1`,
                },
                {
                  value: retido,
                  svg: {
                    fill: '#1880E2',
                  },
                  key: `pie-2`,
                },
              ]}
            />
          )}
          <View style={styles.valuesContainer}>
            <View style={styles.itemContainer}>
              <MaterialCommunityIcons
                name='record-circle'
                style={styles.icon}
                color='#17ACE6'
              />
              <View style={styles.valueContainer}>
                <Text style={styles.valueLabel}>Valor Disponível:</Text>
                <Text style={styles.valueValue}>
                  {disponivel !== -1 ? `R$ ${formatNumber(disponivel)}` : '--'}
                </Text>
              </View>
            </View>
            <View style={styles.itemContainer}>
              <MaterialCommunityIcons
                name='record-circle'
                style={styles.icon}
                color='#1880E2'
              />
              <View style={styles.valueContainer}>
                <Text style={styles.valueLabel}>Valor Retido:</Text>
                <Text style={styles.valueValue}>
                  {retido !== -1 ? `R$ ${formatNumber(retido)}` : '--'}
                </Text>
              </View>
            </View>
            <View style={styles.itemContainer}>
              <View style={styles.valueContainer}>
                <Text style={styles.patrimonioLabel}>Patrimônio Total:</Text>
                <Text style={styles.patrimonioValue}>
                  {patrimonio !== -1 ? `R$ ${formatNumber(patrimonio)}` : '--'}
                </Text>
              </View>
            </View>
          </View>
        </View>
      </ScrollView>
    </>
  );
};

export default Home;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
    flex: 1,
  },
  homeContainer: {
    margin: 16,
  },
  valuesContainer: {
    marginTop: 16,
  },
  itemContainer: {
    flexDirection: 'row',
    marginTop: 16,
  },
  icon: {
    fontSize: 22,
    marginRight: 16,
    marginTop: 6,
  },
  valueContainer: {},
  valueLabel: {
    fontSize: 28,
    color: '#fff',
  },
  valueValue: {
    fontSize: 38,
    color: '#fff',
  },
  patrimonioLabel: {
    marginTop: 16,
    fontSize: 38,
    color: '#fff',
  },
  patrimonioValue: {
    fontSize: 44,
    color: '#fff',
  },
});
